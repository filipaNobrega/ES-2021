using System.Windows.Forms;
using Christmas.Patterns;

namespace Christmas.Shopping.Commands
{
    class CommandCreateNode : ICommand
    {
        public CommandCreateNode(TreeNodeCollection nodes, int imageIndex, ISubject subject)
        {
            Nodes = nodes;

            Node = new TreeNode { Text = subject.ToString() };
            Node.ImageIndex = Node.SelectedImageIndex = imageIndex;
            Node.Tag = subject;

            subject.OnUpdate += (sender, data) => Node.Text = subject.ToString();
        }

        public TreeNodeCollection Nodes { get; }

        public TreeNode Node { get; }

        public void Execute()
        {
            Nodes.Add(Node);
        }

        public void Undo()
        {
            Nodes.Remove(Node);
        }

        public void Redo()
        {
            Execute();
        }
    }
}