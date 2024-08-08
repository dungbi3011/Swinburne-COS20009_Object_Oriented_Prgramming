class Clock():
    
    def __init__ (self, ):
        self._second = 0
        self._minute = 0
        self._hour = 0

    def Tick(self):

        self._second += 1
        if self._second == 60:
            self._minute += 1
            self._second = 0

            if self._minute == 60:
                self._hour += 1
                self._minute = 0

                if self._hour == 24:
                    self._hour = 0


    def PrintTime(self):
        return str("%02d"%self._hour) + ":" + str("%02d"%self._minute) + ":"  + str("%02d"%self._second) 

#Main Function:

time = Clock()
for i in range(0,3600):
    time.Tick()
    print(time.PrintTime())