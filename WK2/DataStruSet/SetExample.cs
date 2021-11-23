
   static void Main() {
      string[] arr1 = {"Table","Chair","Pen","Clip","Table"};
      Console.WriteLine(string.Join(",", arr1));

      // HashSet
      var h = new HashSet<string>(arr1);

      // eliminates duplicate words
      string[] arr2 = h.ToArray();
      Console.WriteLine(string.Join(",", arr2));
   }

   Main();