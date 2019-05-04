DOCKER_TAG='latest'

# log into docker hub.
docker login -u $DOCKER_USERNAME -p $DOCKER_PASSWORD

# build the docker image.
docker build -f ./Dockerfile -t bejebeje/api:$DOCKER_TAG -t bejebeje/api:$TRAVIS_BUILD_NUMBER . --no-cache

# tag the docker image with latest.
docker tag bejebeje/api:$DOCKER_TAG $DOCKER_USERNAME/bejebeje/api:$DOCKER_TAG

# tag the docker image with build number.
docker tag bejebeje/api:$DOCKER_TAG $DOCKER_USERNAME/bejebeje/api:$TRAVIS_BUILD_NUMBER

# push the docker image (tagged latest) to docker hub.
docker push bejebeje/api:$DOCKER_TAG

# push the docker image (tagged with build number) to docker hub.
docker push bejebeje/api:$TRAVIS_BUILD_NUMBER