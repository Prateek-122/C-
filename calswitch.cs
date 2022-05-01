class calswitch
{
	static void Main(string [] args)
	{
		int v1=100;
		int v2=50;
		char op='*';
		int result=0;
		switch (op)
		{
			case '+':
			result=v1+v2;
			break;
			case '-':
			result=v1-v2;
			break;
			case '*':
			result=v1*v2;
			break;
			case '/':
			result=v1/v2;
			break;
			default:System.Console.WriteLine("invalid operator");
			break;
		}
		if (result!=0)
		System.Console.WriteLine(v1+""+op+""+v2+"="+result);
	}
}