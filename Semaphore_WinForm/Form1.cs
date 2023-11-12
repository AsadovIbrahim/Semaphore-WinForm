namespace Semaphore_WinForm
{
    public partial class Form1 : Form
    {
        public List<string> createdthreads = new();
        public List<string> workingthreads = new();
        public List<string> waitingthreads = new();
        public List<Thread> Threads = new();
        public int currentThreadId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void SomeMethod(object? state)
        {
            var semaphore = state as Semaphore;

            if (semaphore is null)
                return;


            bool isFinish = false;

            while (!isFinish)
            {
                if (semaphore.WaitOne(2000))
                {
                    try
                    {
                        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} got the key");
                        Thread.Sleep(6000);
                    }
                    finally
                    {
                        isFinish = true;
                        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} returned the key");
                        semaphore.Release();
                    }
                }
                else
                {
                    Console.WriteLine($"Mister Thread number {Thread.CurrentThread.ManagedThreadId}, we have not enough keys. Please wait ...");
                }
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Method);
            createdthreads.Add($"Thread:{thread.ManagedThreadId}");
            Threads.Add(thread);
            createdTxtBox.Items.Add($"Thread:{thread.ManagedThreadId}");
        }

        private void Method(object? param)
        {
            Semaphore semaphore = param as Semaphore;
            if (semaphore is null)
                return;


            bool isFinish = false;

            while (!isFinish)
            {
                if (semaphore.WaitOne(2000))
                {
                    try
                    {
                        createdTxtBox.Items.Remove($"Thread:{Threads[currentThreadId].ManagedThreadId}");
                        waitingTxtBox.Items.Add($"Thread:{Threads[currentThreadId].ManagedThreadId}");
                        currentThreadId += 1;
                        Thread.Sleep(6000);
                    }
                    finally
                    {
                        isFinish = true;
                        waitingTxtBox.Items.Remove($"Thread:{Threads[currentThreadId - 1].ManagedThreadId}");
                        waitingTxtBox.Items.Add($"Thread:{Threads[currentThreadId - 1].ManagedThreadId}");
                        currentThreadId -= 1;
                        semaphore.Release();
                    }
                }
                else
                {
                    Console.WriteLine($"Mister Thread number {Thread.CurrentThread.ManagedThreadId}, we have not enough keys. Please wait ...");
                }

            }
        }

        private void createdTxtBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numericUpDown1.Value.ToString(), out int semaphoreValue))
            {
                Semaphore semaphore = new Semaphore(semaphoreValue, semaphoreValue, "SEMAPHORE");
                waitingthreads.Add((createdTxtBox.SelectedItem as string)!);
                Thread waitingThread = new Thread(new ParameterizedThreadStart(WaitingThreadMethod));

                foreach (var thread in Threads)
                {
                    string selectedThreadItem = createdTxtBox.SelectedItem as string;
                    if (selectedThreadItem != null && selectedThreadItem.Length > 6 && int.TryParse(selectedThreadItem.Substring(6), out int selectedThreadId))
                    {
                        if (thread.ManagedThreadId == selectedThreadId)
                        {
                            waitingThread.Start(semaphore);
                        }
                    }
                }

                createdTxtBox.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value in the NumericUpDown control.");
            }
        }

        private void WaitingThreadMethod(object param)
        {
            Semaphore semaphore = param as Semaphore;
            if (semaphore is null)
                return;
        }


    }
}