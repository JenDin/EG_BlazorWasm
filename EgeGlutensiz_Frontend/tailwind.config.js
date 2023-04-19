const colors = require('tailwindcss/colors');
module.exports = {
    purge: {
        enabled: true,
        content: [
            './**/*.html',
            './**/*.razor',
            './**/*.cshtml'
        ],
    },
    darkMode: false,
    variants: {
        extend: {},
    },
    plugins: [],
}