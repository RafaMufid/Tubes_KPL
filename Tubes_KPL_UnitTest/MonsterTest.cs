using Tubes_KPL_Program.Model;
using Tubes_KPL_Program.Service;

namespace Tubes_KPL_UnitTest
{
    [TestClass]
    public class MonsterMenuTest
    {
        private MonsterClient _client;

        [TestInitialize]
        public void Init()
        {
            _client = new MonsterClient();
        }

        [TestMethod]
        public async Task Test_GetAllMonsters_ReturnsList()
        {
            var monsters = await _client.GetAllMonstersAsync();
            Assert.IsNotNull(monsters);
            Assert.IsInstanceOfType(monsters, typeof(List<Monster>));
        }

        [TestMethod]
        public async Task Test_CRUDMonster_Success()
        {
            // Add
            var newMonster = new Monster { name = "TestMonster", health = 100, race = "Goblin", damage = 20 };
            var addResult = await _client.AddMonsterAsync(newMonster);
            Assert.IsTrue(addResult);

            // Fetch Last
            var allMonster = await _client.GetAllMonstersAsync();
            var addedMonster = allMonster.FindLast(m => m.name == "TestMonster");
            Assert.IsNotNull(addedMonster);

            // Update
            addedMonster.name = "UpdatedMonster";
            var updateResult = await _client.UpdateMonsterAsync(addedMonster.id, addedMonster);
            Assert.IsTrue(updateResult);

            // Get By ID
            var fetchedMonster = await _client.GetMonsterByIdAsync(addedMonster.id);
            Assert.IsNotNull(fetchedMonster);
            Assert.AreEqual("UpdatedMonster", fetchedMonster.name);

            // Delete
            var deleteResult = await _client.DeleteMonsterAsync(addedMonster.id);
            Assert.IsTrue(deleteResult);
        }

        [TestMethod]
        public async Task Test_GetMonsterById_InvalidId_ReturnsNull()
        {
            var monster = await _client.GetMonsterByIdAsync(-9999); // ID tidak mungkin ada
            Assert.IsNull(monster);
        }

        [TestMethod]
        public async Task Test_DeleteMonster_InvalidId_ReturnsFalse()
        {
            var result = await _client.DeleteMonsterAsync(-9999); // ID tidak mungkin ada
            Assert.IsFalse(result);
        }
    }
}
