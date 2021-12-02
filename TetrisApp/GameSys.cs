public class GameSys
    {
        public Grid grid;//A changer

        public int score {get;set;}
        
        public int speed {get;set;}
        
        public TimeSpan time {get;set;}

        public GameSys(){
            this.grid = new Grid();
        }

        public GameSys(Grid grid, int score, int speed, TimeSpan time){
            this.grid = grid;
            this.score = score;
            this.speed = speed;
            this.time = time;
        }
        
        public static void StartGame(){
            Grid grid = new Grid();
            TimeSpan time = new TimeSpan(0,0,0);
            GameSys NewGame = new GameSys(grid,0, 0, time);
        }
        
        public void SetScore(int multiplicateur){
            switch (multiplicateur){
                case 1:   //1 ligne clear
                    this.score += 150;
                    break;
                case 2:   //2 ligne clear
                    this.score += 400;
                    break;
                case 3:   //3 ligne clear
                    this.score += 600;
                    break;
                case 4:   //tetris
                    this.score += 1000;
                    break;
                case 5:   //ajout piece
                    this.score += 15;
                    break;
            }
        }
}