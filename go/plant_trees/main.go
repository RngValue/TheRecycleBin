package main

import "fmt"

func plant_trees(w float32, l float32, g float32) float32 {
  if (2*((w-1)+(l-1)))/(g+1) != float32(int32((2*((w-1)+(l-1)))/(g+1))) {
    return 0
  }
  return (2*((w-1)+(l-1)))/(g+1)
}

func main() {
  fmt.Println(plant_trees(3, 3, 1))
  fmt.Println(plant_trees(3, 3, 3))
  fmt.Println(plant_trees(3, 3, 2))
  fmt.Println(plant_trees(3, 3, 0))
  fmt.Println(plant_trees(4, 4, 2))
}
