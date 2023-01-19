#include <vector>

namespace DataStructures {

template <typename T>
class CircularQueue {
    int _size;
    T* _storage;
    int _front = 0;
    int _rear = 0;

   public:
    CircularQueue(int size) : _size{size}, _storage{new T[size]} {}

    void push(T data) {
        if (!isFull()) {
            _storage[_rear] = std::move(data);
            _rear = (_rear + 1) % _size;
        }
    }

    void pop() {
        if (!isEmpty()) {
            _front = (_front + 1) % _size;
        }
    }

    T& top() {
        if (!isEmpty()) {
            return _storage[_front];
        }
    }

    bool isFull() { return ((_rear + 1) % _size) == _front; }
    bool isEmpty() { return _front == _rear; }
};
}  // namespace DataStructures