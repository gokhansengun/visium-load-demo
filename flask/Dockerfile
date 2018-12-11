FROM python:2.7.15

ADD requirements.txt /app/requirements.txt

RUN pip install -r /app/requirements.txt

ADD . /app/

ENV FLASK_APP=/app/flaskr/flaskr.py

RUN flask initdb

ENTRYPOINT [ "flask", "run", "--without-threads", "--host", "0.0.0.0" ]
