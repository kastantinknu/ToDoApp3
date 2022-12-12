const { createProxyMiddleware } = require('http-proxy-middleware');

const context = [
    "/mytodos",
];

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        target: 'https://localhost:7051',
        secure: false
    });

    app.use(appProxy);
};
