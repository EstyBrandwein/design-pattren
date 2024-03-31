

using ProjectDesignPattren;
using ProjectDesignPattren.Files;
using ProjectDesignPattren.Files_Directory;

Branch main = MainBranch.GetInstance();
main.Creat("main", "master");
main.AddDirectory(new Folder());
main.ChangeState();
main.ChangeState();
main.ChangeState();
main.ChangeState();
main.ChangeState();
main.ChangeState();
main.ChangeState();
main.ChangeState();
main.AddDirectory(new MyFile());
main.PrintDirectory();

