using System;
using System.Windows.Forms.Design;

namespace twodolist
{
    public partial class background : Form
    {
        public background()
        {
            InitializeComponent();
        }
        
        private List<TaskItem> tasks = new List<TaskItem>();//intializing a place to store tasks this for the rest of my code to refer to
        private bool[] taskCompleted = new bool[50];// creating a (ARRAY)boolean to refer to later 
        private int taskIdCounter = 1;//this is my task counter which will assign number and unique ID to each task 
        private int[] taskPriority = new int[50]; // this array is used to store Priority 
 
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Task Entered: {txtTask.Text}");//this will bring up a message box that first shows that a task was recieved and what the associating task is 
           
            if (!String.IsNullOrWhiteSpace(txtTask.Text)) //this checks txt task box that i created to see if you there is just blank spaces or no text 
            {
                var taskItem = new TaskItem { TaskId = taskIdCounter++, TaskDescription = txtTask.Text, };
                // variable of task Itewm is intialized and then a unique id with increments to count along with the description of the task
                tasks.Add(taskItem); //adds the list string to the task list 
                taskCompleted[taskIdCounter] = false; // the new task will start as false or incomplete 
                

                string priorityInput = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Your Tasks Priority: 1= LOW, 2= MEDIUM, 3= HIGH:", "SET TASK PRIORITY", "2");  
                //using the input box to be able to enter a number for a priority
                //it will show a pop up box to let them know to enter a task priority
                //default is gonna be set to 2 so that i can be 
                if (int.TryParse(priorityInput, out int priority) && priority >= 1 && priority <= 3)
                {//new if else statment for the priority list spec in this method
                    //try parse  converts to an interger, it will then store the variable and it wont save
                    //if its not an interger 
                    taskPriority[taskIdCounter -1] = priority;
                    // task priority array will associated with task id to assign the priority
                    
                }
                else
                {// if there is NOT a number or a number greater than 3 will 
                    //then assign the priority to 2 which is medium 
                    taskPriority[taskIdCounter -1] = 2; 
                }
                UpdateTaskList();// refreshes the task and should show the new item on the list 
                txtTask.Clear();//clears the input box once it is added to the task list 
            }
            else
            {
                MessageBox.Show("Warning:Please Enter a task before continuing");//this occurs ifyou try to add empty value 
            }
        }

        private void DisplayTasks(List<TaskItem> tasks)
        //creating display tasks method which will write the code out, using taskitem in the list section is where t
        //they will be stored 
        {
            Console.WriteLine("To-DO List:");// prints out string "to do list: "
            foreach (var task in tasks)//will go through each item
            {
                Console.WriteLine($"-{task}"); //this will create a bullet and the task that was created in the text box  
            }
        }
        private void UpdateTaskList()
        {//this is my metho for updating the task list 
            MessageBox.Show("UPDATE TASK LIST...");//this message will show once the method is initalized
            lstTasks.Items.Clear();//this will clear out the tasks before

            for (int i = 0; i < tasks.Count; i++)
            {//This is a LOOP, it will start with the first task which is 0, it will then count from there
                string status = taskCompleted[i] ? "[Completed]" : "[Pending]";
                //this operator will check if the task is completed
                //so if it is true then its complete 
                //but if its false(because Boolean) then it will show pending
                string priorityText = (i < taskPriority.Length)
                     ? (taskPriority[i] == 1 ? "[Low]" : taskPriority[i] == 2 ? "[Medium]" : "[High]")
                     : "[Unknown Priority]";
                lstTasks.Items.Add($"{tasks[i].TaskId}: {tasks[i].TaskDescription} {status} {priorityText}");
                //refering to lsttasks box and the items in it. 
                //then it will will the task ID so number and Description 
                //finally it will show f it complete or not
            }
        }


        private void RemoveTask()//this method I am making to remove the task. I will call it later using my button
        {
            if (lstTasks.SelectedIndex != -1)//first make sure a task is selected. the -1 will return if its nothing
            {
                int index = lstTasks.SelectedIndex;//this first stores the number associated in the index 
                tasks.RemoveAt(index); // Remove from list
                lstTasks.Items.RemoveAt(index); // Remove from ListBox UI
          
            }
            else//using an if else statement if nothing is picked 
            {
                MessageBox.Show("Warning: Please select a task before continuing");
            }   //messagebox that pops up a warning letting the user know they must pick a task before continuing 
        }



        private void bttnRemove_Click(object sender, EventArgs e)
        {//this will occur during a specific circumstance which is when the button is clicked
            RemoveTask();//when button is clicked the method remove task is implemented
                         //which you will have to select a task and then click the button 
        }


        private void SaveTasks() //save task method
        {
            string filePath = Path.Combine(Application.StartupPath, "tasks.txt");
            // first creats a filepath, goes to the folder runs, and make sure that this will be stored there
            File.WriteAllLines(filePath, tasks.Take(taskIdCounter)
                .Select((task, index) => $"{task.TaskId}: {task.TaskDescription} - Priority: {taskPriority[index]}"));
            //writes tasks in files formatted with numbers and then with the description and the priority list
            MessageBox.Show("Your To Do List Has Been Saved!");
            //message box appears that the do list is saved 
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {//this is event handler that will run when it is clicked
            SaveTasks(); //save task methodology is then ran 
        }


        public class TaskItem
        { //will store description and number 
            public int TaskId { get; set; }
            //this is the unique id or Number tht will be stored ie 1,2,3 
            public string TaskDescription { get; set; }
            //descritpion of the task, ie take out trash 
        }

        private void MarkComplete()
            //this is my method to actually perform the task marked as complete
        {
            if (lstTasks.SelectedIndex != -1)
                //this refers to my lst tasks box and is asking it to check with the!= -1
                //if a task has been selected or not.
                //if it was just -1 then it would mean no item is selected 
                //so if i put != this will refer to the opposite 
            {
                int index = lstTasks.SelectedIndex;
                //first step is retrieving the index from the lst tasks 
                taskCompleted[index] = true;
                //this refers to task completed boolean. it was previously false in add button 
                //now it true so that means that the task is completed. 
                UpdateTaskList();
                //this updates the task list with the new information added that its complete 
            }
            else
            {//second part of of my else if statement. Meaning if nothing
                //is selected the message below will pop up
                MessageBox.Show("Mark a Task complete before Continuing");
            }
            
        }

        private void bttnComplete_click(Object sender, EventArgs e)
        {//this is the button that i added to be pressed and will refer to the mark completed task
            MessageBox.Show("You have marked this Task as complete");//this pop up box im using for debugging
            MarkComplete(); //this refers to the mark complete method and will start it
        }

        private void
            TxtInput1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

