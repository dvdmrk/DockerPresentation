# Test Angular App that will serve as the presentation layer of an N-Tier Application
# Linux x64 - Aliased so that artifacts can be referenced later
FROM node:14-alpine as production-build
# Creates App directory on node base image
RUN mkdir -p /app
# Executes future commands from app directory
WORKDIR /app
# Copy package.json into new app directory
COPY package.json /app/
# Install package dependencies
RUN npm install
# Copy everything '.' from the source directory into the '/app/' directory
COPY . /app/
# Run a production build of the contents of the '/app/' directory
RUN npm run build --prod
# Start a web server from an image
FROM nginx
# Copy the output of production-build onto the web server
COPY --from=production-build /app/dist/DockerRockstarSpa /usr/share/nginx/html