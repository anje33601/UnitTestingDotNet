namespace TestProjectTodo
{

    
    internal class Todo
    {
        private string _title;

        
        private bool _compleated;
        public Todo(string title, bool compleated)
        {
            if(title == null)
            {
                throw new System.ArgumentNullException();
            }
            _title = title;
            _compleated = compleated;

        }
        public bool SetCompleated(bool value)
        {
            if( _compleated == true)
            {
                return false;
            }
            else { 
            _compleated = value;
                return true;
            }

        }
        public bool GetCompleated()
        {
            return _compleated;
        }
        public string SetTitle(string title)
        {
            _title = title;
            return _title;
        }

        public string GetTitle()
        {
            return _title;
        }
       
        
    }
}