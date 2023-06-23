// See https://aka.ms/new-console-template for more information
using DSA_Programs.Assignments;

Console.WriteLine("Hello, World!");


//********************************Assignments*****************************************



//CountOfPrimes.solve(0);
//CountOfPrimes.solve(1);
//CountOfPrimes.solve(2);
//CountOfPrimes.solve(3);
//CountOfPrimes.solve(4);
//CountOfPrimes.solve(5);
//CountOfPrimes.solve(9);
//CountOfPrimes.solve(1000);
//CountOfPrimes.solve(1001);
//CountOfPrimes.solve(500);

//PerfectNumber.solve(0);
//PerfectNumber.solve(1000001);
//PerfectNumber.solve(1000000);
//PerfectNumber.solve(1);
//PerfectNumber.solve(2);
//PerfectNumber.solve(500000);

//SquareRoot.solve(1);
//SquareRoot.solve(2);
//SquareRoot.solve(4);
//SquareRoot.solve(4);
//SquareRoot.solve(84630800);            

//PrimeNumber.solve(0); //0 - not a prime
//PrimeNumber.solve(1); //0 - not a prime
//PrimeNumber.solve(2); //1 - a prime
//PrimeNumber.solve(3); //1 - a prime
//PrimeNumber.solve(7); //1 - a prime
//PrimeNumber.solve(9); //1 - not a prime

//CountFactors.solve(49);
//CountFactors.solve(24);
//CountFactors.solve(637759701);

//********************************RandomPrograms*****************************************
//////------------------------LengthOfLongestSubstring------------------------------
//LengthOfLongestSubstring lengthOfLongestSubstring = new LengthOfLongestSubstring();
//lengthOfLongestSubstring.FindLengthOfLongestSubstring("dvdf");  // Not working code to be refactored
//geektrust.LengthOfLongestSubstring("abcabcbb");
//geektrust.LengthOfLongestSubstring("");
//geektrust.LengthOfLongestSubstring("bbbbb");
//geektrust.LengthOfLongestSubstring("pwwkew");

//////------------------------MajorityElement------------------------------
//MajorityElement majorityElement = new MajorityElement();
//List<int> elements = new List<int>() { 2, 4, 4, 2, 4, 6, 8, 4, 4, 4 };
//Console.WriteLine(majorityElement.FindMajorityElement(elements));


////------------------------TotalDistanceTravelled------------------------
//TotalDistanceTravelled totalDistanceTravelled = new TotalDistanceTravelled();
////Console.WriteLine(totalDistanceTravelled.DistanceTraveled(1, 1));
//Console.WriteLine(totalDistanceTravelled.DistanceTraveled(11, 1));
//Console.WriteLine(totalDistanceTravelled.DistanceTraveled(11, 5));
//Console.WriteLine(totalDistanceTravelled.DistanceTraveled(5, 1));
//Console.WriteLine(totalDistanceTravelled.DistanceTraveled(5, 2));

////------------------------Anagram----------------------------------------
//Anagram anagram = new Anagram();
//anagram.Check_If_Anagram("Shubham", "BhamShu");
//anagram.Check_If_Anagram("hubham", "BhamShu");
//// END: Anagram

////------------------------OverlappingRectangles----------------------------------------
//OverlappingRectangles overlappingRectangles = new OverlappingRectangles();

//Rectangle[] rectangles = { new Rectangle(1,1,4,5), new Rectangle(2, 2, 4, 5) };

//overlappingRectangles.FindOverLappingRectangles(rectangles);

////------------------------CheckIfSquareBasedOnCoordinates------------------------------
//CheckIfSquareBasedOnCoordinates obj = new CheckIfSquareBasedOnCoordinates();

//Points[] points1 = { new Points(0, 0), new Points(0, 1), new Points(1, 0), new Points(1, 1) };

//Console.WriteLine(obj.IsSquare(points1)); // Output: True

//Points[] points2 = { new Points(0, 0), new Points(0, 1), new Points(1, 0), new Points(2, 1) };

//Console.WriteLine(obj.IsSquare(points2)); // Output:: False
////------------------------CheckIfSquareBasedOnCoordinates------------------------------


//-----------------------------------------------------------------------

//List<int> D = new List<int>()
//{
//    1,2,3,2,1
//};

//Console.WriteLine(findp(D, 5));

//findDiffofMaxAndMin(D);

//Console.WriteLine("Hello World!");

//List<int> C= new List<int>()
//{
//    88,2,46,66,89,-79,36,72,30, 60, 89, 23, 60, 26, -43, -14, 20, 92, -48, 45, 84, -22, 65, -57, 7
//    //4,-1,1
//};

////solve_1(C);

//List<int> A = new List<int>()
//{
//    1,2,2,1
//};

//List<int> B = new List<int>()
//{
//   2,3,1,2
//};

//Console.WriteLine(B.Count);
//solve(A, B);

//Console.WriteLine(calpow(-1, 1, 20));
//Console.WriteLine(Math.Abs(Math.Pow(-1, 1) % 20));


//Console.WriteLine(calpow(2, 2, 5));
//Console.WriteLine(Math.Pow(2,2) % 5);


//Solution solution = new Solution();

//// Test cases
//Console.WriteLine(solution.solution("NAABXXAN"));          // Output: 1
//Console.WriteLine(solution.solution("NAANAAXNABABYNNBZ")); // Output: 2
//Console.WriteLine(solution.solution("QABAAAWOBL"));        // Output: 0

//Console.WriteLine(solution.solution("BANANA"));             // Output: 1 (Only one occurrence of "BANANA" can be removed)
//Console.WriteLine(solution.solution("BBBBBAAAAANANAN"));   // Output: 3 (Multiple occurrences of "BANANA" can be removed)
//Console.WriteLine(solution.solution("NNNNAAAAABBBBB"));   // Output: 2 (Multiple occurrences of "BANANA" can be removed)
//Console.WriteLine(solution.solution("AANANANABANANANANA")); // Output: 4 (Multiple occurrences of "BANANA" can be removed)
//Console.WriteLine(solution.solution("AAANANANANANANANA"));  // Output: 0 (Insufficient 'B', 'A', and 'N' to form "BANANA")

//Console.WriteLine(solution.solution("ANBANANBANANAN"));            // Output: 2 (Multiple occurrences of "BANANA" can be removed)
//Console.WriteLine(solution.solution("ABNANANBANANANAN"));          // Output: 3 (Multiple occurrences of "BANANA" can be removed)
//Console.WriteLine(solution.solution("BANANANANANANANANAN"));        // Output: 6 (Multiple occurrences of "BANANA" can be removed)
//Console.WriteLine(solution.solution("BBBANANAANANAANANANANBANANA")); // Output: 7 (Multiple occurrences of "BANANA" can be removed)
//Console.WriteLine(solution.solution("NAANANANABANANANA"));          // Output: 1 (Only one occurrence of "BANANA" can be removed)


////Solution_2 solution = new Solution_2();

//// Test cases
//Console.WriteLine(solution.solution(2, "1A 2F"));           // Output: 2
//Console.WriteLine(solution.solution(1, ""));              // Output: 2
//Console.WriteLine(solution.solution(22, "1A 3C 2B 20G 5A"));// Output: 41

//var employee = new[]
//{
//    new { Name  ="Shubham"}
//};

Console.ReadLine();
//********************************RandomPrograms*****************************************

