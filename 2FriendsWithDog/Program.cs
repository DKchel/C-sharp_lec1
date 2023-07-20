int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int count = 0;
int dogspeed = 5;
int Friend = 2;
int distance = 10000;
int time = 0;

while(distance > 10)
{
    if (Friend == 1)
    {
        time = distance / (FirstFriendSpeed + dogspeed);
        Friend = 2;
    }
    
    if (Friend == 2)
    {
        time = distance / (SecondFriendSpeed + dogspeed);
        Friend = 1;
    }
    
distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
count++;
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");