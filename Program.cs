namespace Character
{
    // ? Make other characters (neutral) ?
    // TODO: Make protagonist and antagonist complete with character type (shy, funny, intelligent) and add removoe methods
    class protagonist
    {
        List<String> protagonists = new List<string>() {};
        public protagonist(int hp, string type, int luck)
        {
            
        }
        public void remove(string listitem)
        {
            protagonists.Remove(listitem);
        }
    }
    class antagonist
    {
        List<String> antagonists = new List<string>() {};
        public antagonist(int hp, string type, int badluck)
        {
            
        }
        public void remove(string listitem)
        {
            antagonists.Remove(listitem);
        }
    }
    class NPC
    {
        
    }
}