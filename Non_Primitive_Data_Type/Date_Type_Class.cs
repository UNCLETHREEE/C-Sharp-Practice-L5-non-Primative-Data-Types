using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Date_Type_Class : MonoBehaviour
{


   //---------------------------------------------------------------------
// Question 1: Player Class
// Create a class named "Player" to represent a character in a role-playing game.
// Include attributes for the player's name, level, health points (HP), and experience points (XP).
// Implement methods to level up the player, heal the player, and gain experience points.
// Hint: Declare a class with properties for name, level, HP, and XP. Implement methods to increase level, heal HP, and gain XP.
/* Think about how players progress in a typical RPG game. Consider what actions a player can take and how they affect the player's attributes. */

    
    public class Player
    {
        public string name;
        public int level;
        public int hp;
        public int xp;

        public Player(string name)
        {
            this.name = name;
            level = 1;
            hp = 100;
            xp = 0;
        }

        public void LevelUp()
        {
            level++;
            hp += 20;
            Debug.Log($"{name} leveled up to Level {level}! HP increased to {hp}.");
        }

        public void Heal(int amount)
        {
            hp += amount;
            Debug.Log($"{name} healed for {amount} HP. Total HP: {hp}.");
        }

        public void GainXP(int amount)
        {
            xp += amount;
            Debug.Log($"{name} gained {amount} XP. Total XP: {xp}.");
        }
    }

   //---------------------------------------------------------------------
// Question 2: Enemy Class
// Develop a class called "Enemy" to represent adversaries in a video game.
// Include properties for the enemy's name, health points (HP), attack power, and defense.
// Implement methods to calculate damage inflicted by the enemy and to update their HP.
// Hint: Define a class with attributes for name, HP, attack power, and defense. Create methods to calculate damage and update HP.
/* Consider the role enemies play in games. They typically attack players and can be defeated by reducing their HP to zero. */
 // --------------------------------------
    // Question 2: Enemy Class
    public class Enemy
    {
        public string name;
        public int hp;
        public int attackPower;
        public int defense;

        public Enemy(string name, int hp, int attack, int defense)
        {
            this.name = name;
            this.hp = hp;
            this.attackPower = attack;
            this.defense = defense;
        }

        public int CalculateDamage()
        {
            int damage = attackPower - (defense / 2);
            return Mathf.Max(damage, 1);
        }

        public void TakeDamage(int damage)
        {
            hp -= damage;
            hp = Mathf.Max(hp, 0);
            Debug.Log($"{name} took {damage} damage. Remaining HP: {hp}.");
        }
    }
//---------------------------------------------------------------------
// Question 3: Potion Class
// Design a class named "Potion" to model health-restoring items in an adventure game.
// Include properties for the potion's name, healing power, and quantity in inventory.
// Implement a method to apply the potion to a player character and restore their health.
// Hint: Define a class with attributes for name, healing power, and quantity. Create a method to apply the potion and heal the player.
/* Think about how healing items function in games. They typically restore a portion of a player's health when consumed. */

    public class Potion
    {
        public string name;
        public int healingPower;
        public int quantity;

        public Potion(string name, int healingPower, int quantity)
        {
            this.name = name;
            this.healingPower = healingPower;
            this.quantity = quantity;
        }

        public void Use(Player player)
        {
            if (quantity > 0)
            {
                player.Heal(healingPower);
                quantity--;
                Debug.Log($"{player.name} used {name}. {quantity} left.");
            }
            else
            {
                Debug.Log($"{name} is out of stock!");
            }
        }
    }

//---------------------------------------------------------------------
// Question 4: Quest Class
// Create a class called "Quest" to represent tasks or missions in a quest-based game.
// Include properties for the quest's name, description, reward, and completion status.
// Implement methods to start the quest, complete the quest, and claim the reward.
// Hint: Define a class with attributes for name, description, reward, and completion status. Implement methods to manage quest progress.
/* Consider the structure of quests in games. They often involve objectives, rewards, and tracking completion status. */

    public class Quest
    {
        public string name;
        public string description;
        public string reward;
        public bool isCompleted;

        public Quest(string name, string description, string reward)
        {
            this.name = name;
            this.description = description;
            this.reward = reward;
            isCompleted = false;
        }

        public void StartQuest()
        {
            Debug.Log($"Quest started: {name}\n{description}");
        }

        public void CompleteQuest()
        {
            isCompleted = true;
            Debug.Log($"Quest completed: {name}");
        }

        public void ClaimReward()
        {
            if (isCompleted)
            {
                Debug.Log($"Reward claimed: {reward}");
            }
            else
            {
                Debug.Log($"You must complete the quest before claiming the reward!");
            }
        }
    }

 //---------------------------------------------------------------------
// Question 5: Inventory Class
// Develop a class named "Inventory" to manage a player's items in a role-playing game.
// Include properties for the inventory's capacity, list of items, and methods to add/remove items.
// Implement functionality to check if an item exists in the inventory and display its details.
// Hint: Define a class with attributes for capacity and a list of items. Create methods to add, remove, and search for items.
/* Think about how inventories work in games. Players can store and manage various items they collect during their adventures. */

    public class Inventory
    {
        public int capacity;
        public List<string> items;

        public Inventory(int capacity)
        {
            this.capacity = capacity;
            items = new List<string>();
        }

        public void AddItem(string item)
        {
            if (items.Count < capacity)
            {
                items.Add(item);
                Debug.Log($"{item} added to inventory.");
            }
            else
            {
                Debug.Log("Inventory is full!");
            }
        }

        public void RemoveItem(string item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Debug.Log($"{item} removed from inventory.");
            }
            else
            {
                Debug.Log($"{item} not found in inventory.");
            }
        }

        public void CheckItem(string item)
        {
            if (items.Contains(item))
            {
                Debug.Log($"{item} is in the inventory.");
            }
            else
            {
                Debug.Log($"{item} is not in the inventory.");
            }
        }

        public void DisplayItems()
        {
            Debug.Log("Inventory Contents:");
            foreach (string item in items)
            {
                Debug.Log("- " + item);
            }
        }
    }

 //---------------------------------------------------------------------
// Question 6: Spell Class
// Design a class called "Spell" to represent magical abilities or spells in a fantasy game.
// Include properties for the spell's name, damage, mana cost, and description.
// Implement methods to cast the spell, consume mana, and display spell details.
// Hint: Define a class with attributes for name, damage, mana cost, and description. Implement methods to cast and describe the spell.
/* Consider the mechanics of spellcasting in fantasy games. Spells often have different effects, costs, and descriptions. */
    public class Spell
    {
        public string name;
        public int damage;
        public int manaCost;
        public string description;

        public Spell(string name, int damage, int manaCost, string description)
        {
            this.name = name;
            this.damage = damage;
            this.manaCost = manaCost;
            this.description = description;
        }

        public void Cast()
        {
            Debug.Log($"Casting {name}! Deals {damage} damage. Costs {manaCost} mana.");
        }

        public void Describe()
        {
            Debug.Log($"Spell: {name}\nDamage: {damage}\nMana Cost: {manaCost}\nDescription: {description}");
        }
    }
}