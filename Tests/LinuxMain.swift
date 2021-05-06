import XCTest

import testInBiTests

var tests = [XCTestCaseEntry]()
tests += testInBiTests.allTests()
XCTMain(tests)
