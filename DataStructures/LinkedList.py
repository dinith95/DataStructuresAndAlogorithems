# implements a Node in a linked list
class Node:
    # value -> value of the node
    # next -> pointer to the next node in the linked list
    def __init__(self, value):
        self.value = value
        self.next = None


class LinkedList:
    def __init__(self, value=None):
        self.head = Node(value)
        self.tail = self.head
        self.length = 1

# print the linked list
    def printList(self):
        current = self.head
        while current:
            print(current.value)
            current = current.next

# add a node to the end of the linked list
    def append(self, value):
        new_node = Node(value)

        # if the linked list is empty, set the head and tail to the new node
        if self.length == 0:
            self.head = new_node
            self.tail = new_node
        else:
            lastNode = self.tail
            lastNode.next = new_node  # set the next pointer of the last node to the new node
            self.tail = new_node  # set the tail to the new node
        self.length += 1

# remove the last node from the linked list
    def pop(self):

        if self.length == 0:
            return None
        current = self.head

        # if there is only one node in the linked list
        if self.head == self.tail:
            lastNode = self.tail  # store the last node before reassigning the tail
            self.tail = None
            self.head = None
            self.length -= 1
            return lastNode.value

        while current:
            # iterate until current.next is the last node
            if current.next == self.tail:
                current.next = None
                lastNode = self.tail  # store the last node before reassigning the tail
                self.tail = current  # set the tail to the current node
                self.length -= 1
                return lastNode.value

            current = current.next

# add a node to the beginning of the linked list
    def prepend(self, value):
        new_node = Node(value)

        # if the linked list is empty, set the head and tail to the new node
        if self.head is None:
            self.head = new_node
            self.tail = new_node
            self.length += 1
            return

        new_node.next = self.head  # set the next pointer of the new node to the current head
        self.head = new_node  # set the head to the new node
        self.length += 1
        return


list = LinkedList(5)
list.append(10)
list.append(15)
list.prepend(1)
# print(list.pop())  # call pop method and print the returned value
list.printList()
