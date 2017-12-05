
    public int colorful(int A) {
                
        
            HashSet<int> hashSet = new HashSet<int>();
            List<int> digits = new List<int>();

            while (A != 0)
            {
                int num = A % 10;
                digits.Add(num);
                A = A / 10;
            }

            digits.Reverse();
            int length = digits.Count();
            for(int i = 0; i < length; i++)
            {
                for(int j = i; j < length; j++)
                {
                    int product = 1;
                    for(int k= i;k<= j; k++)
                    {
                        product *= digits[k]; 
                    }

                    if (hashSet.Contains(product))
                        return 0;

                    hashSet.Add(product);
                }
            }

            return 1;
        
    }
