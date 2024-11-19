using CppAst;

string header = Path.Join(AppContext.BaseDirectory, "libinput/src/libinput.h");
var compilation = CppParser.ParseFile(header);
Console.WriteLine();