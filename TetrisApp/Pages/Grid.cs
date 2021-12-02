public class Grid{
    public Lines[] lignes = {};
    public int width = 10;

    public int height = 25;

    public Dictionary<string, Lines> DicLines = new Dictionary<string, Lines>();

    public Grid(){
        this.width = 10;
        this.height = 25;
        for(int i = this.height; i > 0; i--){
            string lineName =  "ligne" + i.ToString();
            DicLines.Add(lineName, new Lines(this.width));
            this.lignes.Append(DicLines[lineName]);
        }
    }

    public Grid(int width, int height){
        this.width = width;
        this.height = height+5;
        for(int i = height; i > 0; i--){
            string lineName =  "ligne" + i.ToString();
            DicLines.Add(lineName, new Lines(width));
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