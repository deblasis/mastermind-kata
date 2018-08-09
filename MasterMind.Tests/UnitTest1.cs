using System;
using Xunit;

namespace MasterMind.Tests
{

    /*
     * Kata Mastermind
       Difficulty: medium
       
       Have you ever played Mastermind ? 
       This game where one player, a codemaker, has to choose a secret combination of colored pegs and then make it guess to someone else, a codebreaker. 
       The codemaker is answering to each guess attempt of the codebreaker by indicating only the number of well placed colors and the number of correct but misplaced colors.
       
       If you remember playing the game, being the one who guesses is very brain demanding, whereas the other player get bored rapidly.
       
       Problem Description
       The idea of this Kata is to code an algorithm capable of playing this boring role: answering the number of well placed and misplaced colors.
       
       Therefore, your function should return, for a secret and a guessing combination:
       
       the number of well placed colors
       the number of correct but misplaced colors
       A combination can contain any number of pegs but you’d better give the same number for the secret and the guessing. You can use any number of colors.

       Suggested Test Cases
       For a secret [blue, red, green, pink] and a guess [yellow, red, blue, purple] the answer should be : 1 well placed and 1 misplaced.
       
        IMPORTANT:
        Before you start please create a branch with your name
     */

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            var secret = new[] {"blue", "red", "green", "pink"};
            var guess = new[] {"yellow", "red", "blue", "purple"};

            var expectedWellPlaced = 1;//because red inside secret is in the same position as red in guess
            var expectedMisplaced = 1;//because blue is both in guess and secret but the position is different

            var expected = new[] {expectedWellPlaced, expectedMisplaced};

            Assert.Equal(expected, new int[] {});

        }
    }
}
