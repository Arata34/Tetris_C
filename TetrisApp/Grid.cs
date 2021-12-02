public class Grid{
    public Lines[] lignes = {};
    public int width = 10;

    public int height = 25;

    public Dictionary<string, Lines> DicLines = new Dictionary<string, Lines>();

    public Grid(){}

    public Grid(int widht, int height){
        this.width = widht;
        this.height = height+5;
        for(int i = height; i > 0; i--){
            string lineName =  "ligne" + i.ToString();
            DicLines.Add(lineName, new Lines(widht));
            this.lignes.Append(DicLines[lineName]);
        }
    }

    public void ClearGrid(){
        for (int i = this.height; i > 0; i--){
            string lineName =  "ligne" + i.ToString();
            DicLines[lineName].clearLine();
        }
    }

    public bool isFull(){
        string lineName = "ligne" + (this.height-4).ToString();
        for (int i = 0; i < DicLines[lineName].GetLenght(); i++){
            if(DicLines[lineName].cells[i] == 1){
                return true;
            }
        }
        return false;
    }
}