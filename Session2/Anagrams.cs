    public List<List<int>> anagrams(List<string> A) {
         List<List<int>> result = new List<List<int>>();
            Dictionary<String, List<int>> map = new Dictionary<string, List<int>>();


            for(int i = 0; i < A.Count(); i++)
            {
                char[] word = A[i].ToCharArray();
                Array.Sort(word);
                String key = new string(word);

                if (!map.ContainsKey(key))
                {
                    List<int> value = new List<int>();
                    value.Add(i + 1);
                    map.Add(key, value);
                }
                else
                    map[key].Add(i+1);
            }

            foreach(var item in map.Values)
            {
                result.Add(item);
            }
            return result;
    }
