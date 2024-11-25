//List op når der samles et nyt item op og print det til brugeren

public class Inventory{
  private string name;
  private Item[] pocket = new Item[5];//find ud af om det er brugebart senere


public Inventory(string name, Item[] pocket){
  this.name = name;
  this.pocket = pocket;
}
//Metode til at putte ting ind tasken
public void AddItem(Item newItem){
  for(int i = 0; i < pocket.Length; i++){
    if(pocket[i] == null){
      pocket[i] = newItem;
      break;
    }
  }
}

//Metode til at fjerne ting fra tasken - ved ikke om det er brugebart endnu
// Hvis vi vil fjernes mere end 1 item, skal der inddrages et break.
public void RemoveItem(Item removeItem){
  for(int i = 0; i < pocket.Length; i++){
    if(pocket[i] == removeItem){
      pocket[i] = null;
      break;
    }
  }
}

//print af pocket - direkte
public void PrintInventory(Item[] pocket){
  Console.WriteLine($"Din lomme indeholder: {pocket}")
  }
}