# RiotWrapper.NET
An asynchronus .NET wrapper for the League of Legends API
# Rate Limiting
When you get rate limitted by the wrapper and you restart your app you have to wait longer to make another request so just wait when the program doesn't make any requests anymore! The basic wrapper app rate limit is 98 requests in 120 seconds and 18 requests in 1 second.  More info on the [developers page.](https://developer.riotgames.com/rate-limiting.html)
### Possibilities on how you can hit the real rate limit
The wrapper needs at least one request to get your current rates.
<br> 1.By making 98 requests in less than two minutes.
<br> 2.Then restarting the program and make another call in still less than two minutes.
<br> 3.Repeating second step.
<br> Then you have hit the real api rate limit with 100 reuqests in two minutes!
### <br> AVOID THESE STEPS ABOVE!

# Package available through Nuget
https://www.nuget.org/packages/RiotWrapper.NET/


