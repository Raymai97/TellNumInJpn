# Tell number in Japanese
Program that converts number to Japanese in form of Kanji, Hiragana and Romaji.

### This repo is outdated and for memento purpose only. I've rewritten it using better and more portable code: https://github.com/Raymai97/JpnNumText

Latest version: TellNumInJpn v1.2.1 (21/2/2015)

First written by Raymai97 on 19 Feb 2015 (CNY2015)

Email: cheeboonray@gmail.com

toKanji and toHiragana split the number into parts (that are <= 9999) and pass them to _toXXX

_toKanji and _toHiragana process number <= 9999, and pass a digit at a time to __toXXX

__toKanji and __toHiragana process the most simplest unit of number aka a digit (0~9)

The methods above are limited to process "number" only.

toRomaji is different, it can process most of the common Hiragana to Romaji

It took me pretty much of effort to figure out a good enough algorithm for it...
I hope my method is not bad btw...
