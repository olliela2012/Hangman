namespace Hangman.Logic;

public sealed record WordTheme(string Name, string[] Words);

public static class WordThemes
{
    public static IReadOnlyList<WordTheme> All { get; } =
    [
        new("Everyday", ["WELCOME", "HANGMAN", "IDEA", "JOKE", "HOLD", "JOINING", "ROOK", "PUZZLE", "BUTTON", "POCKET", "GARDEN", "WINDOW"]),
        new("Animals", ["OTTER", "RABBIT", "PANDA", "TIGER", "DOLPHIN", "BADGER", "FALCON", "TURTLE", "WOMBAT", "PENGUIN", "FOX", "KOALA"]),
        new("Food", ["WAFFLE", "TACO", "NOODLE", "BROWNIE", "POPCORN", "PANCAKE", "PICKLE", "BISCUIT", "MANGO", "PRETZEL", "SUSHI", "MUFFIN"]),
        new("Nature", ["FOREST", "MEADOW", "THUNDER", "VOLCANO", "GLACIER", "RAINDROP", "SUNRISE", "CANYON", "WILDFLOWER", "OCEAN", "BREEZE", "MOUNTAIN"]),
        new("Movies", ["DUNE", "BARBIE", "JAWS", "SHREK", "AVATAR", "TITANIC", "INCEPTION", "GLADIATOR", "WICKED", "FROZEN", "COCO", "MOANA", "PARASITE", "NOPE", "OPPENHEIMER", "INTERSTELLAR"]),
        new("TV Shows", ["FRIENDS", "DEXTER", "SHERLOCK", "ANDOR", "LOST", "SUCCESSION", "SEVERANCE", "THEBEAR", "FLEABAG", "ARCANE", "THEOFFICE", "DARK", "BREAKINGBAD", "STRANGERTHINGS"])
    ];

    public static WordTheme Get(string name) => All.FirstOrDefault(theme => theme.Name == name) ?? All[0];
}
