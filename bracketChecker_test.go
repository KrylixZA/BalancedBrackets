package main

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func TestCheck_GivenEmptyString_ShouldReturnOkay(t *testing.T) {
	// Arrange
	input := ""

	// Act
	okay := Check(input)

	// Assert
	assert.True(t, okay)
}

func TestCheck_GivenPairOfSquareBrackets_ShouldReturnOkay(t *testing.T) {
	// Arrange
	input := "[]"

	// Act
	okay := Check(input)

	// Assert
	assert.True(t, okay)
}

func TestCheck_GivenTwoPairsOfSquareBrackets_ShouldReturnOkay(t *testing.T) {
	// Arrange
	input := "[][]"

	// Act
	okay := Check(input)

	// Assert
	assert.True(t, okay)
}

func TestCheck_GivenNestedSquareBrackets_ShouldReturnOkay(t *testing.T) {
	// Arrange
	input := "[[]]"

	// Act
	okay := Check(input)

	// Assert
	assert.True(t, okay)
}

func TestCheck_GivenTripleNestedSquareBrackets_ShouldReturnOkay(t *testing.T) {
	// Arrange
	input := "[[[][]]]"

	// Act
	okay := Check(input)

	// Assert
	assert.True(t, okay)
}

func TestCheck_GivenBackwardsPairOfSquareBracket_ShouldReturnNotOkay(t *testing.T) {
	// Arrange
	input := "]["

	// Act
	okay := Check(input)

	// Assert
	assert.False(t, okay)
}

func TestCheck_GivenRandomOrderOfSquareBrackets_ShouldReturnNotOkay(t *testing.T) {
	// Arrange
	input := "[][]]["

	// Act
	okay := Check(input)

	// Assert
	assert.False(t, okay)
}

//TODO: Make this cater for round brackets and braces as well :)
