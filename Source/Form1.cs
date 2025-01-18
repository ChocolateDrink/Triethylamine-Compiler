using System.Diagnostics;
using compiler.Source;

namespace compiler
{
	public partial class TriethylamineCompiler : Form
	{
		private string lastError = "";

		private readonly Utilities utils = new();

		public TriethylamineCompiler()
		{
			InitializeComponent();
		}

		private void CompileButton_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					var goCheck = new ProcessStartInfo()
					{
						FileName = "go",
						Arguments = "version",
						RedirectStandardInput = true,
						UseShellExecute = false,
						CreateNoWindow = true
					};

					using (var proc = Process.Start(goCheck))
					{
						proc.WaitForExit();
						if (proc.ExitCode != 0)
							throw new Exception("go in not installed");
					}
				}
				catch (Exception)
				{
					CompilationStatus.Text = "compilation failed (1)";
					CompilationStatus.ForeColor = Color.Red;

					return;
				}


				string thisDir = Directory.GetCurrentDirectory();
				string filePath = Path.Combine(thisDir, @"..\..\main\store\shared.go");

				if (!File.Exists(filePath))
				{
					CompilationStatus.Text = "compilation failed (2)";
					CompilationStatus.ForeColor = Color.Red;
					return;
				}

				string fileText = File.ReadAllText(filePath);
				fileText = fileText.Replace("TOKEN  = \"\"", $"TOKEN  = \"{utils.Encrypt(BotTokenText.Text)}\"");
				fileText = fileText.Replace("SERVER = \"\"", $"SERVER = \"{utils.Encrypt(ServerIdText.Text)}\"");

				File.WriteAllText(filePath, fileText);

				string srcPath = Path.Combine(thisDir, @"..\..\main\src\main.go");
                string file = (String.IsNullOrEmpty(ExecNameText.Text) || String.IsNullOrWhiteSpace(ExecNameText.Text)) ? "Triethylamine" : ExecNameText.Text;

                var build = new ProcessStartInfo()
				{
					FileName = "go",
					Arguments = $"build -o {Path.Combine(thisDir, $@"..\..\main\{file}.exe")} {srcPath}",
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					UseShellExecute = false,
					CreateNoWindow = true
				};

				using (var proc = Process.Start(build))
				{
					proc.WaitForExit();

					if (proc.ExitCode != 0)
					{
						lastError = proc.StandardError.ReadToEnd();
						DebugButton.Visible = true;

						CompilationStatus.Text = "compilation failed (3)";
						CompilationStatus.ForeColor = Color.Red;
						return;
					}
				}

				CompilationStatus.Text = "compilation successful";
				CompilationStatus.ForeColor = Color.LightGreen;

				OpenCompiledExec.Visible = true;
			}
			catch (Exception ex)
			{
				lastError = ex.ToString();
				DebugButton.Visible = true;

				CompilationStatus.Text = "compilation failed (4)";
				CompilationStatus.ForeColor = Color.Red;
			}
		}

		private void DebugButton_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(lastError))
				return;

			Clipboard.SetText(lastError);
		}

		private void OpenCompiledExec_Click(object sender, EventArgs e)
		{
			try
			{
				string file = (String.IsNullOrEmpty(ExecNameText.Text) || String.IsNullOrWhiteSpace(ExecNameText.Text)) ? "Triethylamine" : ExecNameText.Text;
				string dir = Path.GetFullPath($@"..\..\main\{file}.exe");

				if (!File.Exists(dir)) return;

				Process.Start("explorer.exe", $"/select,\"{dir}\"");
			}
			catch { }
		}
	}
}