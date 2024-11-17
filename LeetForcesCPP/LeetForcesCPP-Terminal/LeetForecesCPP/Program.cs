string s = "the sky is blue";

string[] sSplitted = s.Split(" ");

// foreach (string sSplittedOne in sSplitted  ){
//   for (int i = 0; i < sSplitted.Length; i ){
    
//   }
// }
// System.Console.WriteLine(sSplitted.Length );
for (int i = sSplitted.Length - 1; i >= 0; i--) {
  // System.Console.WriteLine(sSplitted[i]);
  Console.WriteLine(sSplitted[i]);
}