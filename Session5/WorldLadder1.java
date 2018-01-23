        Queue<WordNode> queue = new LinkedList<WordNode>();
        queue.offer(new WordNode(start, 1));
        dictV.add(end);
        Set<String> set = new HashSet<String>(dictV);
        while(!queue.isEmpty()){
            WordNode top = queue.poll();
            String word = top.word;
            
            //if reached end word return number of steps till then
            if(word.equals(end))
                return top.numSteps;
            
            char[] arr = word.toCharArray();
            for(int i =0; i < arr.length; i++){
                for(char c = 'a'; c <= 'z'; c++){
                    char temp = arr[i];
                    if(arr[i] != c)
                        arr[i] = c;
                    //For each character change compare the new word in dictionary
                    String newWord = new String(arr);
                    if(set.contains(newWord)){
                        queue.offer(new WordNode(newWord, top.numSteps + 1));
                        set.remove(newWord);
                    }
                    arr[i] = temp;
                    
                }
            }
            
        }
                  
        return 0;
