int	xa = 40, ya =  1, 
	xb =  1, yb = 30,
	xc = 80, yc = 30;

int count = 0, x = xa, y = ya, selector = 0;

Console.Clear();

while(count < 10000){
    selector = new Random().Next(0,3);

    if(selector == 0){
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(selector == 1){
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(selector == 2){
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");

    count++;
}