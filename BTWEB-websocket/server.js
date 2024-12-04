const http = require('http');
const WebSocket = require('ws');

const server = http.createServer();
const wss = new WebSocket.Server({ server });

let connections = 0;

wss.on('connection', (ws) => {
  connections++;

  console.log('New client connected. Total connections:', connections);

  const interval = setInterval(() => {
    const data = {
      serverTime: new Date().toLocaleString(),
      connections,
    };
    ws.send(JSON.stringify(data));
  }, 1000);

  ws.on('close', () => {
    connections--;
    console.log('Client disconnected. Total connections:', connections);
    clearInterval(interval);
  });
});

const PORT = 4000;
server.listen(PORT, () => {
  console.log(`🚀 WebSocket server is running at ws://localhost:${PORT}`);
});