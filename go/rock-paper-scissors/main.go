//"Rock, Paper, Scissors" (https://edabit.com/challenge/MYqnQ3DpPZi9di4iW)
package main

import "fmt"

func rps(playerOne string, playerTwo string) string {
  var a string
  if playerOne == playerTwo {
    a = "TIE"
  } else if playerOne == "rock" && playerTwo == "paper" {
    a = "player 2 wins"
  } else if playerOne == "paper" && playerTwo == "rock" {
    a = "player 1 wins"
  } else if playerOne == "scissors" && playerTwo == "rock" {
    a = "player 2 wins"
  } else if playerOne == "rock" && playerTwo == "scissors" {
    a = "player 1 wins"
  } else if playerOne == "paper" && playerTwo == "scissors" {
    a = "player 2 wins"
  } else if playerOne == "scissors" && playerTwo == "paper" {
    a = "player 1 wins"
  }
  return a
}

func main() {
  fmt.Println(rps("rock", "paper"))
  fmt.Println(rps("paper", "rock"))
  fmt.Println(rps("paper", "scissors"))
  fmt.Println(rps("scissors", "scissors"))
  fmt.Println(rps("scissors", "paper"))
}
