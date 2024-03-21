public class BreathingActivity: Activity
{
        public BreathingActivity()
        {
            _name = "Breathing Activity";
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        public void Run()
        {
            //Start
            DisplayStartingMessage();

            //Begin Activity
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while(DateTime.Now < endTime) 
            {
                Console.WriteLine("Breathe In . . . ");
                ShowCountDown(5);
                Console.WriteLine("Breathe Out . . . ");
                ShowCountDown(5);
            }

            //End
            DisplayEndingMessage();
        }
}