We evaluated on two tasks: 1) Switchboard (Godfrey et al., 1992), specifically the HUB5 eval 2001 set having a total of 60K words spoken by 120 speakers, and 2) an ICSI Meeting recorder (Morgan et al, 2001) eval set having a total of 44K words spoken by 25 speakers.
H01-1051
N. Morgan et al.2001. The meeting project at ICSI.
H01-1051
First we extended the baseline vocabulary with words from a small in-domain training corpus (Schwarm and Ostendorf, 2002), and then we used N-grams with these new words in our web queries, e.g. “wireless mikes like”, “I know that recognizer” for a meeting transcription task (Morgan et al, 2001).
H01-1051
We then piped the text through a maximum entropy sentence boundary detector (Ratnaparkhi, 1996) and performed text normalization using NSW tools (Sproat et al, 2001).
W96-0213
