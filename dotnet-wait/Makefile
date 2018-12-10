build:
	docker-compose -f stack.yml build

deploy:
	docker stack deploy -c stack.yml wait

rm:
	docker stack rm wait

ps:
	docker stack ps wait

push:
	docker-compose -f stack.yml push

pull:
	docker-compose -f stack.yml pull
