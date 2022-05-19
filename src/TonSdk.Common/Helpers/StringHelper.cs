using System.Text;

namespace TonSdk.Common.Helpers
{
    public static class StringExtensions
    {
        public static string ToCamelCase(this string text)
        {
            if (string.IsNullOrEmpty(text) || !char.IsUpper(text[0]))
            {
                return text;
            }

            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (i == 1 && !char.IsUpper(chars[i]))
                {
                    break;
                }

                bool hasNext = (i + 1 < chars.Length);
                if (i > 0 && hasNext && !char.IsUpper(chars[i + 1]))
                {
                    // if the next character is a space, which is not considered uppercase 
                    // (otherwise we wouldn't be here...)
                    // we want to ensure that the following:
                    // 'FOO bar' is rewritten as 'foo bar', and not as 'foO bar'
                    // The code was written in such a way that the first word in uppercase
                    // ends when if finds an uppercase letter followed by a lowercase letter.
                    // now a ' ' (space, (char)32) is considered not upper
                    // but in that case we still want our current character to become lowercase
                    if (char.IsSeparator(chars[i + 1]))
                    {
                        chars[i] = ToLower(chars[i]);
                    }

                    break;
                }

                chars[i] = ToLower(chars[i]);
            }

            return new string(chars);
        }

        private static char ToLower(this char character)
        {
#if HAVE_CHAR_TO_LOWER_WITH_CULTURE
            character = char.ToLower(character, CultureInfo.InvariantCulture);
#else
            character = char.ToLowerInvariant(character);
#endif
            return character;
        }

        public static string ToSnakeCase(this string text) => ToSeparatedCase(text, '_');

        public static string ToKebabCase(this string text) => ToSeparatedCase(text, '-');

        private enum SeparatedCaseState
        {
            Start,
            Lower,
            Upper,
            NewWord
        }

        private static string ToSeparatedCase(this string text, char separator)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            StringBuilder sb = new StringBuilder();
            SeparatedCaseState state = SeparatedCaseState.Start;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    if (state != SeparatedCaseState.Start)
                    {
                        state = SeparatedCaseState.NewWord;
                    }
                }
                else if (char.IsUpper(text[i]))
                {
                    switch (state)
                    {
                        case SeparatedCaseState.Upper:
                            bool hasNext = (i + 1 < text.Length);
                            if (i > 0 && hasNext)
                            {
                                char nextChar = text[i + 1];
                                if (!char.IsUpper(nextChar) && nextChar != separator)
                                {
                                    sb.Append(separator);
                                }
                            }
                            break;
                        case SeparatedCaseState.Lower:
                        case SeparatedCaseState.NewWord:
                            sb.Append(separator);
                            break;
                    }

                    char character;
#if HAVE_CHAR_TO_LOWER_WITH_CULTURE
                    c = char.ToLower(s[i], CultureInfo.InvariantCulture);
#else
                    character = char.ToLowerInvariant(text[i]);
#endif
                    sb.Append(character);

                    state = SeparatedCaseState.Upper;
                }
                else if (text[i] == separator)
                {
                    sb.Append(separator);
                    state = SeparatedCaseState.Start;
                }
                else
                {
                    if (state == SeparatedCaseState.NewWord)
                    {
                        sb.Append(separator);
                    }

                    sb.Append(text[i]);
                    state = SeparatedCaseState.Lower;
                }
            }

            return sb.ToString();
        }
    }
}
