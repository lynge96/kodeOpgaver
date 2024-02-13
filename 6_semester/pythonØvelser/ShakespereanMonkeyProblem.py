import random

target_string = "To be or not to be.."
population_size = 100
mutation_rate = 0.1
crossover_rate = 0.8

def generate_random_string(length):
    return ''.join(random.choice("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ .,;'-") for _ in range(length))

def fitness(string):
    return sum(1 for c1, c2 in zip(string, target_string) if c1 == c2)

def select_parents(population):
    population.sort(key=lambda x: fitness(x), reverse=True)
    elite_size = int(0.1 * len(population))
    return population[:elite_size]

def crossover(parent1, parent2):
    crossover_point = random.randint(1, len(parent1) - 1)
    child1 = parent1[:crossover_point] + parent2[crossover_point:]
    child2 = parent2[:crossover_point] + parent1[crossover_point:]
    return child1, child2

def mutate(child):
    mutated_index = random.randint(0, len(child) - 1)
    mutated_char = random.choice("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ .,;'-")
    return child[:mutated_index] + mutated_char + child[mutated_index + 1:]

def generate_next_population(parents):
    next_population = parents.copy()

    while len(next_population) < population_size:
        parent1, parent2 = random.sample(parents, 2)
        child1, child2 = crossover(parent1, parent2)

        if random.random() < mutation_rate:
            child1 = mutate(child1)
        if random.random() < mutation_rate:
            child2 = mutate(child2)

        next_population.extend([child1, child2])

    return next_population[:population_size]

# Initialization
current_population = [generate_random_string(len(target_string)) for _ in range(population_size)]
generation = 0

while True:
    print(f"Generation {generation}")
    current_population = generate_next_population(select_parents(current_population))

    best_string = max(current_population, key=fitness)
    best_fitness = fitness(best_string)

    print(f"Best String: {best_string}")
    print(f"Fitness: {best_fitness}")

    if best_string == target_string:
        print("Solution found!")
        break

    generation += 1
