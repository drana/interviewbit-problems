string sort(vector <int> A);
int comp(string a, string b){
   return a+b > b+a;
}
string Solution::largestNumber(const vector<int> &A) {
    // Do not write main() function.
    // Do not read input, instead use the arguments to the function.
    // Do not print the output, instead return values as specified
    // Still have a doubt. Checkout www.interviewbit.com/pages/sample_codes/ for more details

     vector <string > B;
    bool Allzero = true;
    for(int i=0;i<A.size();i++){
        B.push_back(to_string(A[i]) );
        if(A[i]!=0)
            Allzero = false;
    }
    if(Allzero)
        return "0";
    sort(B.begin(), B.end(), comp);
    
    string ans="";
    
    for(int i=0;i<B.size();i++){
        ans+=B[i];
    }
    return ans;
}




