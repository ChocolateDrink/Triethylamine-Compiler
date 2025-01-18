namespace compiler.Source
{
	public class Utilities
	{
		public string Encrypt(string text)
		{
			char[] buffer = text.ToCharArray();
			for (int i = 0; i < buffer.Length; i++)
			{
				if (!char.IsLetterOrDigit(buffer[i]))
					continue;

				char letter = buffer[i];
				char shifted;

				if (char.IsLetter(letter))
				{
					shifted = (char)(letter + 9);

					if (char.IsLower(letter))
					{
						if (shifted > 'z')
							shifted = (char)(shifted - 26);
					}
					else if (char.IsUpper(letter))
					{
						if (shifted > 'Z')
							shifted = (char)(shifted - 26);
					}
				}
				else if (char.IsDigit(letter))
				{
					shifted = (char)(letter + 9);
					if (shifted > '9')
						shifted = (char)(shifted - 10);
				}
				else
				{
					shifted = letter;
				}

				buffer[i] = shifted;
			}

			return new string(buffer);
		}
	}
}
