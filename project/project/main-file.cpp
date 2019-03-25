#include <SFML/Graphics.hpp>
using namespace sf;
int ground = 150;

class PLAYER { // ������� ����� PLAYER( ��� ����� ����� �������� ��������� �������������� ��� ���������  ����������)

public:
	float dx, dy; // ��������
	FloatRect rect; //  ����� rect(x, y, widht, height)
	bool onGround; //  onGround- ���������, ������� ����������, ��������� �� �������� �� �����
	Sprite sprite; // ���� ����� ��������� ��������
	float currentFrame; //  ������� ���� ��� ��������

	PLAYER(Texture &image)
	{
		sprite.setTexture(image); // � ����������� ������ ��������� ��������
		rect = FloatRect(0, 0, 40, 50); // ��������� �������������� ���������� x=0, y=0, ������-40, ������-50

		dx = dy = 0;
		currentFrame = 0;
	}

	void update(float time)
	{
		rect.left += dx*time; // rect.left-���� ���������� �, ���������� �� �� dx*time

		if (!onGround) dy = dy + 0.0005*time; // ���� �� �� �� �����, �� ������ � ���������� ( ��������� -0.005 �������� �� ����� �������� ��������)
		rect.top += dy*time; // rect.top - ���� ���������� �
		onGround = false;

		if (rect.top > ground)
		{
			rect.top = ground; dy = 0; onGround = true;
		} // �� �� �����

		currentFrame += 0.005*time; // �������� ��������
		if (currentFrame > 6) currentFrame -= 6; // ����� � ��� 6 ������
		if (dx > 0) sprite.setTextureRect(IntRect(40 * int(currentFrame), 244, 40, 50)); // ������ ������ ����������, �� ���� ������� �������� ���������� ������ ��� �� 40( ��� �������� �������- ������ ��������
		if (dx < 0) sprite.setTextureRect(IntRect(40 * int(currentFrame) + 40, 244, -40, 50)); // ��� �������� ������- ����������

		sprite.setPosition(rect.left, rect.top); // ������� ��� ������ � ������� x, y 

		dx = 0;
	}
};

int main()
{
	RenderWindow window(VideoMode(200, 200), "SFMLworks"); // ������� ���� 200 �� 200 � ������ SFMLworks

	Texture t;
	t.loadFromFile("images/fang.png"); // ��������� ��������
	float currentFrame = 0;

	PLAYER p(t); // ��������� ��������

	Clock clock; // �������� ����� � ���������� ����( ����� �������� ��������� ���� �� �������, � �� � �������� ����������)

	while (window.isOpen())
	{
		float time = clock.getElapsedTime().asMicroseconds(); /* ������� ���������� �����, getElapsedTime() - ���� ��������� �����( �������  ��� � �������������) */

		clock.restart(); // ������������� ����
		time = time / 800; //����� ���������� ����������� �������� �������� ���������

		Event event;
		while (window.pollEvent(event))
		{

			if (event.type == Event::Closed)
				window.close(); // ������������ ������� �������� ����
		}
		if (Keyboard::isKeyPressed(Keyboard::Left)) // ���� ������� ������ � ������� ������
		{
			p.dx = -0.1; // ��� ������� ������- ���������� �� -0.1
		}
		if (Keyboard::isKeyPressed(Keyboard::Right)) // ���� ������� ������ � ������� �������
		{
			p.dx = 0.1; // ��� ������� �������- ���������� �� 0.1

		}
		if (Keyboard::isKeyPressed(Keyboard::Up)) // �����
		{
			if (p.onGround) { p.dy = -0.4; p.onGround = false; } // ���� �� �� �����, �� ������ ����� ����� ����������� ������
		}

		p.update(time); // ��������� �����
		window.clear(Color::White); // ������� �����

		window.draw(p.sprite); // ������ ������
		window.display(); // ������� �� �������
	}
	return 0;
}