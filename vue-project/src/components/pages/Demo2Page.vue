<template>
    <div class="relative w-full mx-auto overflow-hidden " style="height: calc(1000px);">
        <!-- Hình ảnh -->
        <img src="../../assets/HomeImage/header-background.jpg" alt="Your Image"
            class=" inset-0 w-full h-full object-top  object-cover ">

        <!-- Phần tử overlay -->
        <div class="absolute inset-0">
            <div class="absolute inset-0 bg-gradient-to-t from-white to-transparent opacity-95"></div>
        </div>

        <!-- Chữ đè lên hình ảnh -->
        <div class="absolute inset-0 flex flex-col items-center justify-center text-center">
            <p class="container text-white text-6xl font-semibold mb-4">Giúp đỡ và thay đổi cuộc sống</p>
            <div class="container text-white text-lg">
                <p>
                    Thông qua các chuyến đi sứ mệnh y tế, Tổ chức Cứu trợ Y tế Quốc tế cung cấp khả năng tiếp cận các dịch vụ y <br>
                    tiếp và giáo dục y tế công cộng bền vững cho cộng đồng chưa được quan tâm và dễ bị tổn thương trên toàn cầu <br>
                    nhằm cải thiện sức khỏe, thể chất và chất lượng cuộc sống của những nhóm cư dân cần nhất.
                </p>
                <br>
            </div>
            <button class="border px-6  py-4 font-medium"> Tham gia cùng chúng tôi </button>
            <br>
            <div class="border bg-[#FF993A] px-8 py-1 font-medium">
                <div class="container text-center max-w-[1135px] mx-auto text-[32px]">
                    <p>Hãy tham gia cùng cũng tôi</p>
                </div>
                <div class="container text-center max-w-[1135px] mx-auto text-[17px]">
                    <p>Những người có cuộc sống tốt được cải thiện hoặc cứu nhờ sức khỏe cộng đồng, giáo dục và can thiệp y tế <br>
                là nhờ vào lòng hảo tâm và những đóng góp từ thiện của bạn.</p>
                </div>
                <div class="col-4 d-flex flex-column justify-content-center">
                <button class="border px-6  py-4 font-medium"> Đóng góp ngay </button>
                </div>
            </div>
            <br>
        <div class="image-overlay-2 text-center">
        <div>
            <img src="../../assets/HomeImage/cuuthuong.png" alt="">
        </div>
        
        </div>
        </div>
    </div>
    <div class="max-w-[1135px] mx-auto">
        <div class="container text-center max-w-[1135px] mx-auto text-[32px]">
            <p >Bạn có thể trở thành một phần trong chuyến đi</p>  
            <p class=" text-[17px]">Chuyến đi của chúng tôi luôn có công việc phù hợp cho mọi người</p>
        </div>
    </div>
    <div class="flex flex-wrap justify-around my-20 ">
            <div class=" mb-10 text-center" v-for="(item) in data" :key="item.id">
                <div class="relative">
                    <img class="w-[330px] h-[190px] object-cover" :src=item.image_url alt="">
                    <div class="absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 text-center">
                        <span class="block text-[#fff] text-3xl font-medium mb-3">{{ item.title }}</span>
                        <button class="border bg-[#FF993A] px-8 py-1 font-medium">Bác sĩ nha khoa</button>
                    </div>
                </div>
            </div>
        </div>
</template>
    
<script>
export default {
    setup() {
        var data = [
            {
                id: 1,
                image_url: 'https://watermark.lovepik.com/photo/20220319/large/lovepik-image-of-female-doctor-holding-tooth-model-in-picture_502369313.jpg',
            },
            {
                id: 2,
                image_url: 'https://dean2020.edu.vn/wp-content/uploads/2020/04/bac-si-nha-khoa-1.jpg',
            }, {
                id: 3,
                image_url: 'https://nhakhoavananh.vn/wp-content/uploads/2022/07/chuyen-nghiep.jpg',
            }, {
                id: 4,
                image_url: 'https://tse3.mm.bing.net/th?id=OIP.0h5cibN1FqMuJYZLKB057AHaE8&pid=Api&P=0&h=180',
            }, {
                id: 5,
                image_url: 'https://nhakhoakim.com/wp-content/uploads/2018/07/nha-khoa-quan-tan-binh.jpg',
            }, {
                id: 6,
                image_url: 'https://img4.thuthuatphanmem.vn/uploads/2021/01/10/hinh-anh-bac-si-nha-khoa-dang-noi-chuyen-voi-benh-nhan_021527848.jpg',
            }, {
                id: 7,
                image_url: 'https://career.gpo.vn/uploads/images/237684310/images/gpo-bac-si-nha-khoa-nha-si-3.jpg',
            }, {
                id: 8,
                image_url: 'https://detec.vn/wp-content/uploads/2020/11/Nhung-dieu-ban-chua-biet-ve-co-hoi-lam-viec-trong-nganh-nha-khoa-2.jpg',
            }
        ];

        return {
            data
        }
    }
}
</script>

<style lang="scss" scoped></style>