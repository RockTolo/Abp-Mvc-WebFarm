docker-compose up -d tolo_redis
sleep 3
docker-compose up -d tolo_admin_1
sleep 2
docker-compose up -d tolo_admin_2
sleep 2
docker-compose up -d load_balancer