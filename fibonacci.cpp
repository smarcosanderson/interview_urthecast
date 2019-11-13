#include <iostream>

//By just using the golden ratio we can find the nth fibonacci number in O(1) time complexity
//this function is designed for n >= 0
int fibonacci(int n)
{
	static double goldenRatio = (1 + std::sqrt(5)) / 2;
	return static_cast<int>((std::pow(goldenRatio, n) - std::pow((1 - goldenRatio), n)) / std::sqrt(5));
}

//using for loops - just for fun
//this function is designed for n >= 0
int fibLoop(int n)
{
	if (n == 0 || n == 1)
		return n;

	int n0 = 0;
	int n1 = 1;
	int fib = 1;

	for (int i = 1; i < n; i++)
	{
		fib = n0 + n1;
		n0 = n1;
		n1 = fib;
	}

	return fib;
}


int main()
{
	for (int i = 0; i < 20; i++)
	{
		std::cout << "fibonacci(" << i << ")   =   " << fibonacci(i) << std::endl;
	}

	system("pause"); // for testing in Windows
	//std::cin.get(); // if testing in other OS
	return 0;
}
