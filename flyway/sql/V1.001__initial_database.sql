CREATE SCHEMA IF NOT EXISTS users;

CREATE TABLE users.user_preferences (
    user_id VARCHAR(50) NOT NULL,
    preference_id VARCHAR(50) NOT NULL,
    preference_value VARCHAR(50) NOT NULL,
    PRIMARY KEY (user_id, preference_id)
);

CREATE INDEX users_preferences_userid_idx ON users.user_preferences(user_id);

INSERT INTO users.user_preferences(user_id, preference_id, preference_value) VALUES
    ('1e489a21-a110-4131-8a68-ef7bacfca9c9', 'global.timezone', 'America/Monterrey'),
    ('1e489a21-a110-4131-8a68-ef7bacfca9c9', 'home.state.selected', 'NL'),
    ('1e489a21-a110-4131-8a68-ef7bacfca9c9', 'home.city.selected', 'MTY')