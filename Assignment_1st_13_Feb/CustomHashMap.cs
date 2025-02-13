/* using System;

class CustomHashMap{
    private const int Size = 100;
    private List<KeyValuePair<int,int>>[] map = new List<KeyValuePair<int,int>>[Size];
    public void Put(int key,int value){
        int index = key%Size;
        if(map[index]==null){
            map[index] = new List<KeyValuePair<int,int>>();
		}
        for(int i=0;i<map[index].Count;i++){
            if(map[index][i].Key==key){
                map[index][i] = new KeyValuePair<int,int>(key,value);
                return;
            }
        }
        map[index].Add(new KeyValuePair<int, int>(key, value));
    }
    public int Get(int key){
        int index = key%Size;
        if(map[index]!=null){
            foreach(var pair in map[index]){
                if(pair.Key==key){
                    return pair.Value;
				}
			}
        }
        return -1;
    }
    public void Remove(int key){
        int index = key%Size;
        if(map[index]!=null){
            map[index].RemoveAll(pair => pair.Key==key);
        }
    }
    public static void Main(){
        CustomHashMap hashMap = new CustomHashMap();
        hashMap.Put(1,10);
        hashMap.Put(2,20);
        Console.WriteLine(hashMap.Get(1));
        hashMap.Remove(1);
        Console.WriteLine(hashMap.Get(2));
    }
}
 */