package main

import (
	"github.com/golang-collections/collections/stack"
)

func Check(input string) bool {
	// Here we are going to use a stack to keep all the opening braces.
	// Every time we encounter a new opening brace, push it into the stack.
	// Every time we encounter a closing brace, pop one from the opening stack.
	// If the order of brackets is correct, every opening bracket will have a closing bracket, resulting in an empty stack at the end.
	// If the stack is not empty, the order is incorrect.
	openBracketStack := stack.New()

	for _, char := range input {
		if char == rune('[') {
			openBracketStack.Push(char)
		} else if char == rune(']') {
			openBracketStack.Pop()
		}
	}

	if openBracketStack.Len() == 0 {
		return true
	}

	return false
}
