    module.exports = {
        modulePaths: ['src/'],
        verbose: true,
        testPathIgnorePatterns: ['fixtures'],
        globals: {},
        setupFilesAfterEnv: ["./allure-report.ts"],
    }