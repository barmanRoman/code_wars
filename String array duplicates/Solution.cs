using System;
using System.Text;
using System.Linq;
public class Solution
{
    public static string[] dup(string[] arr)
    {
        if(arr == null)
        {
            throw new ArgumentException();
        }
		return arr.Select(item=>DeleteDublicate(item)).ToArray();
    }

	private static string DeleteDublicate(string item)
	{
		if(string.IsNullOrEmpty(item))
        {
            throw new ArgumentException("String is null or empty");
        }

        StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(item[0]);
		
        for (int i = 1; i < item.Length; i++)
        {
			if(item[i] != item[i-1])
			{
				stringBuilder.Append(item[i]);
			}
        }

		return stringBuilder.ToString();
	}
}