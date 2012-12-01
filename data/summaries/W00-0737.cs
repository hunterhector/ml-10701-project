The idea of using statistics for chunking goes back to Church(1988), who used corpus frequencies to determine the boundaries of simple nonrecursive noun phrases.
A88-1019
Such works include Bod(1992) for parsing, Argamon et a1.(1998) for shallow natural language patterns and Daelemans et a1.(1999) for shallow parsing.
C92-3126 P98-1010 W99-0707
• 00: the current input token and the previous one have the same parent • 90: one ancestor of the current input token and the previous input token have the same parent • 09: the current input token and one ancestor of the previous input token have the same parent • 99 one ancestor of the current input token and one ancestor of the previous input token have the same parent Compared with the B-Chunk and I-Chunk used in Ramshaw and Marcus(1995)~, structural relations 99 and 90 correspond to B-Chunk which represents the first word of the chunk, and structural relations 00 and 09 correspond to I-Chunk which represents each other in the chunk while 90 also means the beginning of the sentence and 09 means the end of the sentence.
W95-0107
