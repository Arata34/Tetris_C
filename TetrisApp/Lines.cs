public class Lines{
    public int[] cells = {};

    public Lines(int Lenght){
        int[] temp = new int[Lenght];
        for(int i = 0; i < Lenght; i++){
            temp.Append(0);
        }
        cells = temp;
    }

    public bool isFull(){
        for(int i = 0; i < this.cells.Length; i++){
            if(this.cells[i] == 0 ){
                return false;
            }
        }
        return true;
    }

    public void clearLine(){
        for(int i = 0; i < this.cells.Length; i++){
            this.cells[i] = 0;
        }
    }

    public int GetLenght(){
        return cells.Length;
    }
}