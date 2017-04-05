namespace HelloWorld.Models{
    public static class Message{
        public static string Get(string name){
            return $"Hello, ${name}";
        }
    }
}