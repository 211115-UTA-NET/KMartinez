using System.IO;
using System;


string path = "./testFile.txt";

StreamWriter writer = new StreamWriter(path);



StreamWriter write = new StreamWriter(path);
write.WriteLine("This is a new line.");
write.Close();