using System.ComponentModel;

namespace project
{
    public class Driver
    {
        public static Form1 form;

        public static void cellClicked(int x, int y)
        {
            (x, y) = (y, x);

            form.hint.Text = $@"Selected cell: [{x}, {y}] - There's a {form.matrix[x, y]} there";
        }
    }
}